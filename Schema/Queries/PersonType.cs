using System;

using System.Collections.Generic;

namespace RexixBackend.Schema.Queries
{
    public class PersonType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Shahab Idrees";
        public int Age { get; set; } = 16;
        public string Pattern { get; set; } = "Person";
        public List<Guid> Followers { get; set; } = [new Guid(), new Guid(), new Guid(), new Guid()];
        public List<Guid> Following { get; set; } = [new Guid(), new Guid(), new Guid(), new Guid()];
        public int FollowersCount => Followers.Count;
        //public int FollowingCount => Following.Count;
        //public List<Guid> Reviews { get; set; } 
        public List<Guid> CloseFriends { get; set; } = [new Guid(), new Guid()];
    }
}