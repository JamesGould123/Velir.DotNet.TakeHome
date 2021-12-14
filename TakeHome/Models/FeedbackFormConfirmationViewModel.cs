using System;

namespace TakeHome.Models
{
	public class FeedbackFormConfirmationViewModel
    {
        public FeedbackFormConfirmationViewModel(FeedbackFormModel submittedModel)
        {
            FirstName = submittedModel.FirstName;
            LastName = submittedModel.LastName;
            Email = submittedModel.Email;
            Comments = submittedModel.Comments;
        }

        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public string Comments { get; set; }
	}
}