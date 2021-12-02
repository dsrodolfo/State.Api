using State.Api.Entities;
using State.Api.Interfaces;
using State.Api.Repositories;
using System.Globalization;
using System.IO.Compression;
using System.Reflection;
using System.Text;

namespace State.Api.Services
{
    public class StateService : IStateService
    {
        private readonly string[] _states = { "Acre",  "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás",
                                              "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", 
                                              "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"
                                            };

        private readonly StateRepository _stateRepository;

        public StateService(StateRepository stateRepository)
        {
            _stateRepository = stateRepository;
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

        public string[] GetAllStates() => _states.OrderBy(state => state).ToArray();

        public IEnumerable<StateEntity> GetAllStateEntity() => _stateRepository.GetAllStates();

        public string[] GetAllStatesByName(string name)
        {
            string formattedName = RemoveDiacritics(name.ToLower().Trim());

            return _states.Where(state => RemoveDiacritics(state.ToLower()).StartsWith(formattedName))
                          .OrderBy(state => state)
                          .ToArray();
        }

        private string RemoveDiacritics(string text)
        {
            var clearText = new string(text.Normalize(NormalizationForm.FormD)
                                           .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                                           .ToArray());
            return clearText.Trim();
        }
    }
}