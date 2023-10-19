        public Boolean IsNumber(string input)
        {
                Boolean isNum = false;
                if (int.TryParse(input, out _))
                    {
                       isNum = true;
                    }
            return isNum;
        }
