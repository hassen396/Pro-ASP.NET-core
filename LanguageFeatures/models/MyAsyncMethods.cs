namespace LanguageFeatures.Models;
public class MyAsyncMethod {
public static Task<long?> GetPageLength(){   
    HttpClient c = new HttpClient();
    var httpTask = c.GetAsync("http://mannig.com");
    return httpTask.ContinueWith((Task<HttpResponseMessage> 
    antecedent)=> {
    return antecedent .Result.Content.Headers.ContentLength;
    });
}
}