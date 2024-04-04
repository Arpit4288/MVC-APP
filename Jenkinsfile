pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                echo 'Starting Checkout stage...'
                git url: 'https://github.com/Arpit4288/MVC-APP.git', branch: 'master'
                echo 'Checkout stage completed.'
            }
        }

        stage('List Content') {
            steps {
                echo 'Starting List Content stage...'
                sh 'ls -l'
                echo 'List stage completed.'
            }
        }
        
        stage('Build') {
            steps {
                echo 'Starting Build stage...'
                sh 'dotnet build'
                echo 'Build stage completed.'
            }
        }
        
        stage('Test') {
            steps {
                echo 'Starting Test stage...'
                sh 'dotnet test'
                echo 'Test stage completed.'
            }
        }
    }
}
