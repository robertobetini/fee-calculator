# Fee Calculator
***

## 1. Setup

### 1.1. Install Visual Studio

Go to [Visual Studio download website](https://visualstudio.microsoft.com/pt-br/downloads/) and download Visual Studio 2019 or 2022 Community Edition for your OS. Follow the steps to install it correctly.

After the installation, open the Visual Studio Installer and install modules for ASP.NET web development.

### 1.2. Install Docker

Go to [Docker Desktop website](https://www.docker.com/products/docker-desktop/) and download Docker for your OS and follow the steps to install.

## 2. Running the application

Open `InterestCalculator.sln` with Visual Studio and choose to run it with Docker. You can also run without docker, you only need to change the Start Project configuration by clicking the pointing down arrow at the side of the `Run` button.

## 3. The API

* **[GET]** `/taxa`

Returns the interest value, which is `0.01` by default. You can change this by setting another value to the environment variable `InterestValue`.

* **[GET]** `/calculajuros?valorInicial={decimal}&meses={int}`

This endpoint takes the initial value (`valorInicial`) and calculates the final amount, given the time in months (`meses`) and the interest value, following the equation:

Amount = `valorInicial` * (1 + interest)^`meses` 

i.e., if we have a initial value of 1000.00, a interest value of 10% for 3 months, then:

Amount = 1000.00 * (1 + 0.1)^3 = 1331.00

* **[GET]** `/showmethecode`

Returns a string with the URL to this GitHub repository.
