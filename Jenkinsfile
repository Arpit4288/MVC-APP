pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/Arpit4288/MVC-APP.git', branch: 'master'
            }
        }

        stage('Files'){
            steps{
                sh 'ls -l'
            }
        }
        
        stage('Build') {
            steps {
                sh 'dotnet build'
            }
        }
        
        stage('Test') {
            steps {
                sh 'dotnet test'
            }
        }
    }
}
