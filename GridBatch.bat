Start /C start/MIN java -jar D:\selenium\selenium-server-standalone-3.0.1.jar -role hub -port 4445 -timeout 3000 -browserTimeout 3600

Start /C start/MIN java -jar D:\SeleniumGrid\StandAlone\selenium-server-standalone-3.0.1.jar -role node -Dwebdriver.chrome.driver=D:\ChromeDriver\chromedriver.exe -Dwebdriver.ie.driver=D:\IEDriver\IEDriverServer.exe -hub http://localhost:4445/grid/register -port 5696

Start /C start/MIN java -jar D:\selenium\selenium-server-standalone-2.53.0.jar -role node -Dwebdriver.chrome.driver=D:\ChromeDriver\chromedriver.exe -Dwebdriver.ie.driver=D:\IEDriver\IEDriverServer.exe -hub http://localhost:4445/grid/register -port 5697