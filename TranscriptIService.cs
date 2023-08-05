using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace FileTranscriptionService
{
    [ServiceContract]
    public interface TranscriptIService
    {
        [OperationContract]
        string[] GetTranscription(FileTranscription fileTranscription);
    }

    [DataContract]
    public class FileTranscription
    {
        [DataMember]
        public string FilePath { set; get; }

        [DataMember]
        public int UserId { set; get; }

        [DataMember]
        public string Status { set; get; }

        [DataMember]
        public string Result { set; get; }
    }

}
