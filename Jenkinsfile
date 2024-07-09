pipeline {
    agent any
    stages {
        stage('Stop IIS') {
            steps {
                echo 'Stop IIS'
            }
        }
        stage('Sleep') {
            steps {
                // sleep(5000)
                echo 'Sleep'
            }
        }
        stage('Build') {
            steps {
                echo 'Build'
            }
        }
        stage('Publish') {
            steps {
                echo 'Publish'
            }
        }
        stage('Re-Start IIS') {
            steps {
                echo 'Re-Start IIS'
            }
        }
    }
}