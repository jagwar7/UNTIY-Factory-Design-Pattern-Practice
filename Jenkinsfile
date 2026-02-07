pipeline {
    agent any
    
    options {
        disableConcurrentBuilds()
        buildDiscarder(logRotator(numToKeepStr: '5'))
        skipDefaultCheckout() 
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
            options { timeout(time: 10, unit: 'MINUTES') } 
            steps {
                echo "Running NUnit Tests for: ${env.BRANCH}"
                bat 'if not exist "artifacts" mkdir "artifacts"'
                
                bat """
                call "${env.UNITY_PATH}" ^
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
            script {
                echo "Waiting for slow disk write (RAM Bottleneck workaround)..."
                sleep time: 10, unit: 'SECONDS'
            }
            
            junit testResults: '**/artifacts/results.xml', allowEmptyResults: true
            
            archiveArtifacts artifacts: 'artifacts/*.txt, artifacts/*.xml', allowEmptyArchive: true
        }
        success {
            echo "SUCCESS: The Hierarchy is secure."
        }
        failure {
            echo "FAILURE: Check the archived unity_test_log.txt for C# errors."
        }
    }
}