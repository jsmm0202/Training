using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class DeserializationMissingMemberDemo
    {
        public static void ShowDeserializationMissingMember()
        {
            Console.Clear();
            Console.WriteLine("*** Deserialization Missing Member ***");

            string xavierJsonExtraNameValue = @"{
  'name': 'Xavier Morera',
  'courses': [
    'Solr',
    'dotTrace'
  ],
  'dance': 'Chicken dancer',
  'since': '2014-01-14T00:00:00',
  'issues': null,
  'car': {
    'model': 'Land Rover Series III',
    'year': 1976
  }
}";
            

            Author xavierPocoNoSetting;
            Console.WriteLine("Deserialize with no settings specified");
            xavierPocoNoSetting = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue);
            Console.WriteLine(xavierPocoNoSetting.name);
            //Check value of 'happy' and 'dance'

            Author xavierPocoWithSettingIgnore;
            Console.WriteLine("Deserialize with MissingMemberHandling.Ignore");
            JsonSerializerSettings jsonSettingsIgnore = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            xavierPocoWithSettingIgnore = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue, jsonSettingsIgnore);
            Console.WriteLine(xavierPocoWithSettingIgnore.name);

            try
            {
                Author xavierPocoWithSettingError;
                Console.WriteLine("Deserialize with no settings specified");
                JsonSerializerSettings jsonSettingsError = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Error
                };
                xavierPocoWithSettingError = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue, jsonSettingsError);
                Console.WriteLine(xavierPocoWithSettingError.name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
