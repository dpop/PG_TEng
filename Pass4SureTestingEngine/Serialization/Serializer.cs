using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Pass4SureTestingEngine.Serialization
{
    class Serializer
    {
        public static Encoding Encoding = Encoding.Unicode;

        public static T BinaryDeserializeObject<T>(byte[] serializedType)
        {
            if (serializedType == null)
                throw new ArgumentNullException("serializedType");

            if (serializedType.Length.Equals(0))
                throw new ArgumentException("serializedType");

            T deserializedObject;

            using (MemoryStream memoryStream = new MemoryStream(serializedType))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                deserializedObject = (T)deserializer.Deserialize(memoryStream);
            }

            return deserializedObject;
        }

        public static byte[] BinarySerializeObject(object objectToSerialize)
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException("objectToSerialize");

            byte[] serializedObject;

            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, objectToSerialize);
                serializedObject = stream.ToArray();
            }

            return serializedObject;
        }
    }
}
