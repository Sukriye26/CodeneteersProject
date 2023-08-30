﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobAdvertisementsService
    {
        List<JobAdvertisements> list();
        void add(JobAdvertisements t);
        void delete(JobAdvertisements t);
        void update(JobAdvertisements t);
        JobAdvertisements GetByID(int id);
    }
}
