using AutoMapper;
using State.Application.Extensions;
using State.Application.Interfaces;
using State.Application.Models.Responses;
using State.Domain.Entities;
using State.Infrastructure.Interfaces;
using System.IO.Compression;
using System.Reflection;

namespace State.Application.Services
{
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;
        private readonly IMapper _mapper;

        public StateService(IStateRepository stateRepository, IMapper mapper)
        {
            _stateRepository = stateRepository;
            _mapper = mapper;
        }

        public IEnumerable<StateResponse> GetAllStates()
        {
            IEnumerable<StateEntity> states = _stateRepository.GetAllStates();

            return states.Select(obj => _mapper.Map<StateResponse>(obj)); ;
        }
        public IEnumerable<StateResponse> GetAllStatesByName(string name)
        {
            IEnumerable<StateEntity> states = _stateRepository.GetAllStates();
            IEnumerable<StateEntity> selectedStates = states.Where(x => x.Name
                                                                 .ToLower()
                                                                 .RemoveDiacritics()
                                                                 .StartsWith(name.ToLower().RemoveDiacritics()));

            return selectedStates.Select(st => _mapper.Map<StateResponse>(st));
        }

        public string DownloadFlags()
        {
            string directoryImages = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Images";
            string zipFileDirectory = string.Empty;

            if (Directory.Exists(directoryImages))
            {
                zipFileDirectory = $"{directoryImages}.zip";

                if (File.Exists(zipFileDirectory))
                {
                    File.Delete(zipFileDirectory);
                }
    
                ZipFile.CreateFromDirectory(directoryImages, zipFileDirectory);
            }

            return zipFileDirectory;
        }
    }
}