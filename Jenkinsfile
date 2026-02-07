pipeline {
    agent any
    
    options {
        // Essential for 8GB RAM stability
        disableConcurrentBuilds()
        buildDiscarder(logRotator(numToKeepStr: '5'))
        skipDefaultCheckout() // We do checkout manually in Stage 0
    }

    triggers {
        githubPush()
    }

    environment {
        BRANCH = "${env.BRANCH_NAME}"
        UNITY_PATH = "C:\\Program Files\\Unity\\Hub\\Editor\\2022.3.62f3\\Editor\\Unity.exe"
    }

    stages {
        stage('0. Initialize Environmental Setup') {
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
                echo "Starting automated build for: ${env.BRANCH} by: ${env.BUILD_USER}"
            }
        }

        stage('2. Unity Project Validation') {
            steps {
                script {
                    if (!fileExists('Assets') || !fileExists('ProjectSettings')) {
                        error "This does not look like a Unity project!"
                    }
                }
            }
        }

        stage('3. Run Unity NUnit Tests v2') {
            steps {
                echo "Running NUnit Tests for: ${env.BRANCH}"

                bat 'if not exist "artifacts" mkdir "artifacts"'
                
                bat """
                "${env.UNITY_PATH}" ^
                -batchmode -nographics ^
                -projectPath "%WORKSPACE%" ^
                -runTests -testPlatform EditMode ^
                -testResults "%WORKSPACE%\\artifacts\\results.xml" ^
                -forgetHubSelfUpdate ^
                -burst-disable-compilation ^
                -no-cache ^
                -noproxycache ^
                -logfile "%WORKSPACE%\\artifacts\\unity_test_log.txt"
                """
            }
        }
    }

    post {
        always {
            junit 'artifacts/results.xml'
        }
        success {
            echo "SUCCESS: The Hierarchy is secure."
        }
        failure {
            echo "FAILURE: Notify the department lead immediately."
        }
    }
}