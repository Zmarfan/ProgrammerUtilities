using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerUtils
{
    class SaveService
    {
        public static readonly string SAVE_FOLDER_PATH = "@src" + "/SaveData";
        public static readonly string DATA_ENDING = ".save";

        /// <summary>
        /// Saves specified data indexed by specified name
        /// </summary>
        /// <param name="saveName">Name to save and load this data</param>
        /// <param name="data">Data to save</param>
        /// <returns>Returns true when done saving</returns>
        public static bool Save(string saveName, object data)
        {
            BinaryFormatter formatter = CreateBinaryFormatter();

            //Create folder for saving if one doesn't exist
            if (!Directory.Exists(SAVE_FOLDER_PATH))
                Directory.CreateDirectory(SAVE_FOLDER_PATH);

            string path = SAVE_FOLDER_PATH + "/" + saveName + DATA_ENDING;
            FileStream file = File.Create(path);
            formatter.Serialize(file, data);
            file.Close();
            return true;
        }

        /// <summary>
        /// Returns loaded data indexed by saveName. Null if data don't exist or is damaged
        /// </summary>
        /// <param name="saveName">Name to save and load this data</param>
        /// <returns>Cast return data to expected type</returns>
        public static object Load(string saveName)
        {
            string path = SAVE_FOLDER_PATH + "/" + saveName + DATA_ENDING;
            if (!File.Exists(path))
                return null;

            BinaryFormatter formatter = CreateBinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);

            try
            {
                object data = formatter.Deserialize(file);
                file.Close();
                return data;
            }
            catch
            {
                file.Close();
                return null;
            }
        }

        /// <summary>
        /// Returns a binary formatter that can handle custom non serilized data types
        /// </summary>
        public static BinaryFormatter CreateBinaryFormatter()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            SurrogateSelector selector = new SurrogateSelector();

            HtmlCustomSettingSerilizationSurrogate htmlSurrogate = new HtmlCustomSettingSerilizationSurrogate();

            selector.AddSurrogate(typeof(Color), new StreamingContext(StreamingContextStates.All), htmlSurrogate);

            formatter.SurrogateSelector = selector;
            return formatter;
        }

        public class HtmlCustomSettingSerilizationSurrogate : ISerializationSurrogate
        {
            public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
            {
                HtmlExtraSettings.HtmlCustomSetting setting = (HtmlExtraSettings.HtmlCustomSetting)obj;
                info.AddValue("char", setting.ReplaceChar);
                info.AddValue("string", setting.ReplaceToString);
            }

            public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
            {
                HtmlExtraSettings.HtmlCustomSetting setting = (HtmlExtraSettings.HtmlCustomSetting)obj;
                setting.ReplaceChar = info.GetChar("char");
                setting.ReplaceToString = info.GetString("string");
                return setting;
            }
        }
    }
}
