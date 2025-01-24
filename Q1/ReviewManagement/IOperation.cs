using System;
using System.Collections.Generic;

namespace ReviewSystem
{
    public interface IOperation
    {
        void Execute(List<Review> database, bool isAdminApproved);
    }
}
