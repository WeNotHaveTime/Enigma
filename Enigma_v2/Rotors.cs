//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enigma
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rotors
    {
        public string Name { get; set; }
        public string Rotor { get; set; }
        public int Position { get; set; }
    
        public virtual Main Main { get; set; }
    }
}
