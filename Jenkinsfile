pipeline {
    agent any

    environment {
        BRANCH = "${env.BRANCH_NAME}"

    }

    stages {
        stage('0. Initialize Environment') {
            steps {
                script {
                    def props = readProperties file: '.env'
                    
                    env.BUILD_USER = props['GITHUB_USER']
                    env.DEPARTMENT = props['DEPARTMENT']
                }
            }
        }
        stage('1. Identify Department') {
            steps {
                echo "Starting automated build for: ${env.BRANCH} by: ${env.BUILD_USER}  from : ${env.DEPARTMENT} department"
            }
        }

        stage('2. Unity Project Validation') {
            steps {
                echo "Verifying Unity Project Integrity..."
                script {
                    if (!fileExists('Assets') || !fileExists('ProjectSettings')) {
                        error "This does not look like a Unity project! Check your root folder."
                    }
                }
            }
        }

        stage('3. Run Unity NUnit Tests') {
            steps {
                echo "Running NUnit Tests for Department: ${env.BRANCH}"
                /* SOLID INTERMEDIATE NOTE: 
                   This is a placeholder. Once we link your Unity Editor to Docker, 
                   we will replace this echo with the actual CLI command.
                */
            }
        }
    }

    post {
        success {
            echo "SUCCESS: ${env.BRANCH} passed all checks. The Hierarchy is secure."
        }
        failure {
            echo "FAILURE: ${env.BRANCH} build failed. Notify the department lead immediately."
        }
    }
}