pipeline {
    agent any

    environment {
        DOTNET_SDK_VERSION = '6.0' // Specify the version of the .NET SDK to use
    }
    
    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/Arpit4288/MVC-APP.git', branch: 'master'
            }
        }
        
        stage('Build') {
            steps {
                // Use the withDotNet section for build step
                withDotNet(specificSdkVersion: env.DOTNET_SDK_VERSION) {
                    // Use the dotnetBuild builder to run "dotnet build" command
                    dotnetBuild() 
                }
            }
        }
        
        stage('Test') {
            steps {
                // Similarly, you can add test steps using withDotNet
                withDotNet(specificSdkVersion: env.DOTNET_SDK_VERSION) {
                    // Use the dotnetTest builder to run "dotnet test" command
                    dotnetTest()
                }
            }
        }
    }
}
