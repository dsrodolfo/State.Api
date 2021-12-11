using AutoMapper;
using State.Api.Extensions;
using State.Api.Interfaces;
using State.Api.Models.Response;
using State.Domain.Entities;
using State.Infrastructure.Repositories;
using System.IO.Compression;
using System.Reflection;

namespace State.Api.Services
{
    public class StateService : IStateService
    {
        private readonly StateRepository _stateRepository;
        private readonly IMapper _mapper;

        public StateService(StateRepository stateRepository, IMapper mapper)
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