using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPDotNet_Assignment1.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public string username { get; set; }
        [BindProperty]
        public int password { get; set; }

        public string message;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (username == "virat" && password == 12354)
            {
                message = "Login Successful!";
            }
            else
            {
                message = "Login UnSuccessful!";

            }
        }
    }
}
