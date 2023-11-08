namespace Elias.Data.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        #region Relations
        public ICollection<User> Users { get; set; }
        #endregion
    }
}
