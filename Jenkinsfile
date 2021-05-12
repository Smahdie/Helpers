pipeline{
    agent any
    
    environment {
        dotnet ='C:\\Program Files (x86)\\dotnet\\'
        }
        
    triggers {
        pollSCM 'H * * * *'
    }

    stages{
        stage('Checkout') {
            steps {
                git credentialsId: 'credential_github', url: 'https://github.com/Smahdie/Helpers.git/', branch: 'master'
            }
        }

        stage('Restore packages'){
            steps{
                bat "dotnet restore Helpers.sln"
            }
        }

        stage('Clean'){
            steps{
                bat "dotnet clean Helpers.sln"
            }
        }

        stage('Build'){
            steps{
                bat "dotnet build Helpers.sln --configuration Release"
            }
        }

        stage('Publish'){
            steps{
                bat "dotnetPublish configuration: 'Release', project: 'Helpers/Helpers.csproj'"
            }
        }
    }
 }