namespace TMSLesson10
{
    class Credentials
    {
        public static bool IsValid(string login, string password, string confirmPassword)
        {
            try
            {
                if (login.Length > 20 || login.Contains(' '))
                    throw new WrongLoginException("Логин не соответствует требованиям");

                if (password.Length > 20 || password.Contains(' ') || !password.Any(char.IsDigit))
                    throw new WrongPasswordException("Пароль не соответствует требованиям");

                if (!password.Equals(confirmPassword))
                    throw new WrongPasswordException("Пароли не совпадают");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

    }
}
