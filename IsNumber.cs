        public Boolean IsNumber(char car)
        {
            Boolean isNum;
             
            switch (car)
            {
                case '0':
                    isNum = true;
                    break;
                case '1':
                    isNum = true;
                    break;
                case '2':
                    isNum = true;
                    break;
                case '3':
                    isNum = true;
                    break;
                case '4':
                    isNum = true;
                    break;
                case '5':
                    isNum = true;
                    break;
                case '6':
                    isNum = true;
                    break;
                case '7':
                    isNum = true;
                    break;
                case '8':
                    isNum = true;
                    break;
                case '9':
                    isNum = true;
                    break;
                default:
                    isNum = false;
                    break;
            }
            return isNum;
        }
