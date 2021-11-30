﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest.Models
{
    public class ContactWebConstants
    {
        // Limiting the number of allowed inputs in the database to perserve space

        public const int MAX_STATE_NAME_LENGTH = 50;

        public const int MAX_STATE_ABBR_LENGTH = 4;

        public const int MAX_FIRST_NAME_LENGTH = 50;

        public const int MAX_LAST_NAME_LENGTH = 250;

        public const int MAX_EMAIL_LENGTH = 250;

        public const int MAX_PHONE_LENGTH = 15;

        public const int MAX_STEET_ADDRESS_LENGTH = 250;

        public const int MAX_CITY_LENGTH = 50;

        public const int MAX_ZIP_CODE_LENGTH = 10;

        public const int MIN_ZIP_CODE_LENGTH = 5;

    }
}
