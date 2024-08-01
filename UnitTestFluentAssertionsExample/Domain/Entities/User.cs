namespace Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; set; }

        public User(string fullName)
        {
            FullName = fullName;
            SplitFullName();
        }

        private void SplitFullName()
        {
            var names = FullName.Split(' ');
            FirstName = names[0];
            LastName = names[1];
        }
    }
}
