pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/Arpit4288/MVC-APP.git', branch: 'master'
            }
        }
        
        stage('Build') {
            steps {
                // Use the withDotNet section for build step
                withDotNet {
                    // Use the dotnetBuild builder to run "dotnet build" command
                    dotnetBuild() 
                }
            }
        }
        
        stage('Test') {
            steps {
                // Similarly, you can add test steps using withDotNet
                withDotNet {
                    // Use the dotnetTest builder to run "dotnet test" command
                    dotnetTest()
                }
            }
        }
    }
}
