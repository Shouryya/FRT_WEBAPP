using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PLANWISER.MODELS;
using Azure.AI.OpenAI;
namespace PLANWISER.Pages{

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    [BindProperty]
    public ProjectValues Details{get;set;}=new();

    public string StudyPlan{get;set;}
    public void OnGet()
    {

    }
    public void onPost(){
        var key="e8a05d2fbc0f41bbb94042686fce9f55";
        var endpoint="https://planner7890.openai.azure.com/";
        var deployment="Companion1234";

        OpenAIClient aiClient=new(new Uri(endpoint),new Azure.AzureKeyCredential(key));
        var prompt =$"Give me a study plan for {Details.deadline} number of days,i can give {Details.hours_per_day} hours in a day and my syllabus to be covered is {Details.syllabus}.";
         ChatCompletionOptions chatOptions = new ChatCompletionOptions(){
            Messages=
            {
                new ChatMessage(ChatRole.System,"You are a helpful AI bot."),
                new ChatMessage(ChatRole.user,prompt)

            }
         };
         ChatCompletions responseCompletion=aiClient.GetChatCompletions(deployment,chatOptions);
         StudyPlan=responseCompletion.Choices[0].Message.Content;
         }
}
}