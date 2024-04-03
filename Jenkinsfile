pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git(url: 'https://github.com/Arpit4288/Basic-DotNet-Web-App.git', branch: 'master')
            }
        }

        stage('Build') {
            steps {
                // Change directory to the location of your solution file
                dir('Basic DotNet Web App') {
                    // Execute the build command using shell
                    sh 'dotnet build'
                }
            }
        }

        stage('Test') {
            steps {
                // Change directory to the location of your solution file
                dir('Basic DotNet Web App') {
                    // Execute the test command using shell
                    sh 'dotnet test'
                }
            }
        }
    }
}
