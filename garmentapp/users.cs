//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace garmentapp
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int roleid { get; set; }
    
        public virtual order order { get; set; }
        public virtual role role { get; set; }
    }
}
