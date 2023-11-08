namespace Elias.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Familly { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserImage { get; set; }
        public string Ostan { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public string Resumeh { get; set; }
        public string MainSkill { get; set; }
        public string Skills { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Skype { get; set; }


        #region Relations
        public Role Role { get; set; }
        #endregion
    }
}
