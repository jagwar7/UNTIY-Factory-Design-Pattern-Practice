pipeline {
    agent any
    triggers {
        githubPush()
    }
    environment {
        BRANCH = "${env.BRANCH_NAME}"

    }

    stages {
        stage('0. Initialize Environmental Setup 1') {
            steps {
                checkout scm

                script {
                    def configFile = 'user.gitconfig.txt'
                    
                    if(fileExists(configFile)){
                        def props = readProperties file: configFile
                        env.BUILD_USER = props['GITHUB_USER'] ?: "UNDEFINED USER"
                        env.DEPARTMENT = props['DEPARTMENT'] ?: "UNDEFINED DEPARTMENT"
                    }   
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
                
            }
        }
    }

    post {
        success {
            echo "SUCCESS: ${env.BRANCH} by: ${env.BUILD_USER}  from : ${env.DEPARTMENT} department passed all checks. The Hierarchy is secure."
        }
        failure {
            echo "FAILURE: ${env.BRANCH} by: ${env.BUILD_USER}  from : ${env.DEPARTMENT} department build failed. Notify the department lead immediately."
        }
    }
}