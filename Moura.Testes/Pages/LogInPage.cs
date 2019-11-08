using OpenQA.Selenium;

namespace Pages
{

    public class LogIn
    {

        private IWebDriver driver;

        public string url = "https://mourasite1.jnmoura.com.br/PET_APRESENTACAO/Login.aspx";

        public LogIn(IWebDriver driverAtual)
        {
            driver = driverAtual;
        }

        // Mapeamento de elementos
        private IWebElement LogInInput() => driver.FindElement(By.Id("txtUsuario"));

        private IWebElement SenhaInput() => driver.FindElement(By.Id("txtSenha"));

        private IWebElement EntrarButton() => driver.FindElement(By.Id("btnEntrar"));

        // Ação dos elementos
        public void InserirLogin(string login)
        {
            LogInInput().SendKeys(login);
        }

        public void InserirSenha(string senha)
        {
            SenhaInput().SendKeys(senha);
        }

        public void ClicarEntrar()
        {
            EntrarButton().Click();
        }

        // Comportamentos
        public void Logar(string login, string senha)
        {
            InserirLogin(login);
            InserirSenha(senha);
            ClicarEntrar();
        }
    }
}
