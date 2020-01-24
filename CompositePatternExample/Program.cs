using System;

namespace CompositePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var registrationValidation = new Message("The registration was not carried out!");

            var userFormError = new Message("The user entered an invalid name");

            var sizeNameForm = new InputFormMessage("The name must be longer than 2 characters");
            var emptyNameForm = new InputFormMessage("The name cannot have numbers");

            userFormError.AddChild(sizeNameForm);
            userFormError.AddChild(emptyNameForm);

            registrationValidation.AddChild(userFormError);

            var domainUserError = new Message("Problems processing the user registration");

            var cpfUserDomain = new DomainMessage("The CPF informed is in use!");
            var emailUserDomain = new DomainMessage("The EMAIL informed is in use!");

            domainUserError.AddChild(cpfUserDomain);
            domainUserError.AddChild(emailUserDomain);

            registrationValidation.AddChild(domainUserError);

            var msgLevel1 = new Message("Level 1");
            var msgLevel2 = new Message("Level 2");
            var msgLevel3 = new Message("Level 3");
            var msgLevel4 = new Message("Level 4");
            var msgLevel5 = new Message("Level 5");

            msgLevel4.AddChild(msgLevel5);
            msgLevel3.AddChild(msgLevel4);
            msgLevel2.AddChild(msgLevel3);
            msgLevel1.AddChild(msgLevel2);

            registrationValidation.AddChild(msgLevel1);

            registrationValidation.ShowMessages(2);
        }
    }
}
