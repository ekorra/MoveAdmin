﻿using System;
using System.Threading.Tasks;
using MoveAdmin.Commons;
using Newtonsoft.Json;

namespace MoveAdmin.Lib
{
    public class Organisation
    {
        private readonly ISrrClient srrClient;
        public string OrganisationNumber { get; set; }
        public string Name { get; set; }

        public AltInnSrrRights AltInnSrrRights { get; set; }

        public Organisation(ISrrClient srrClient)
        {
            this.srrClient = srrClient;
        }

        public async Task GetInforation(int orgnr)
        {
           
            AltInnSrrRights = await srrClient.GetRights(orgnr);
        }
        
        public string GetOrgName(string orgnr)
        {
            return null;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
