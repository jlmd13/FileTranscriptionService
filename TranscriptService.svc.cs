using DOM.Transcriptions;
using DOM.TranscriptionService;
using DOM.TranscriptionService.Enums;

namespace FileTranscriptionService
{
    public class TranscriptService : TranscriptIService
    {
        public string[] GetTranscription(FileTranscription fileTranscription)
        {
            TranscriptionServiceMock transcriptionServiceMock = new TranscriptionServiceMock();

            //En un caso real obviamente recibiríamos los bytes del archivo no la ruta, pero para emular la funcionalidad me he basado sólo en el título
            TranscriptionResult transcriptionResult = transcriptionServiceMock.TranscriptFile(fileTranscription.FilePath);
            fileTranscription.Result = transcriptionResult.TranscriptionStatus.Equals(TranscriptionStatusEnum.Ok) ? transcriptionResult.Result : string.Empty;

            return new string[] { transcriptionResult.TranscriptionStatus.ToString(), fileTranscription.Result};
        }
    }
}

