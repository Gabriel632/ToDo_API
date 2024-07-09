pipeline {
    agent any
    stages {
        stage('Stop IIS') {
            steps {
                bat '"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe" Stop-WebSite ''ToDo'''
            }
        }
        stage('Sleep') {
            steps {
                sleep(5000)
            }
        }
        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release'
            }
        }
        stage('Publish') {
            steps {
                bat 'dotnet publish -c Release -o C:\\Repositorio\\inetpub\\wwwToDo'
            }
        }
        stage('Re-Start IIS') {
            steps {
                bat '"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe" Start-WebSite ''ToDo'''
            }
        }
    }
}