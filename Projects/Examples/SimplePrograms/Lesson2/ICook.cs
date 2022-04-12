using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    interface ICook
    {
        //опис методів, які мають бути реалізовані у всіх класах, що будуть реалізовувати інтерфейс ICook
        Food GetFood();

    }
}
