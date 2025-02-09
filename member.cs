
namespace Assignment3_classes
{
    // FILE: Member.cs
    // DESCRIPTION: Defines a Member class for a social club with unique ID, personal details, and methods.

    internal class Member
    {
        // Static variable to keep track of the next available Member ID.
        public static int nextMemberID = 1;

        // Stores the unique ID of the member
        public int memberID;
        // Stores the first name of the member
        public string firstName;
        // Stores the last name of the member
        public string lastName;
        // Stores the email address of the member
        public string emailAddress;
        // Stores the date of birth of the member
        public DateTime dateOfBirth;

        // METHOD: SetAllData
        // DESCRIPTION: Assigns values to all data fields and generates a unique Member ID.
        public void SetAllData(string fName, string lName, string email, DateTime dob)
        {
            // Assign and increment unique ID
            memberID = nextMemberID++;
            // Assigns first name
            firstName = fName;
            // Assigns last name
            lastName = lName;
            // Assigns email address
            emailAddress = email;
            // Assigns date of birth
            dateOfBirth = dob;
        }

        // METHOD: GetName
        // DESCRIPTION: Returns the full name in "Last Name First Name" format.
        public string GetName()
        {
            // Returns formatted name
            return $"{lastName} {firstName}";
        }

        // METHOD: CalculateAge
        // DESCRIPTION: Calculates the member's age based on their date of birth.
        public int CalculateAge()
        {
            // Get current date
            DateTime today = DateTime.Today;
            // Calculate age difference in years
            int age = today.Year - dateOfBirth.Year;
            // Return calculated age
            return age;
        }

        // METHOD: GetMemberID
        // DESCRIPTION: Returns the unique ID assigned to the member.
        public int GetMemberID()
        {
            // Return the unique member ID
            return memberID;
        }
    }
}
