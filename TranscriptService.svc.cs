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
            TranscriptionResult transcriptionResult = transcriptionServiceMock.TranscriptFile(fileTranscription.FilePath);
            fileTranscription.Result = transcriptionResult.TranscriptionStatus.Equals(TranscriptionStatusEnum.Ok) ? transcriptionResult.Result : string.Empty;

            return new string[] { transcriptionResult.TranscriptionStatus.ToString(), fileTranscription.Result};
        }
    }
}

