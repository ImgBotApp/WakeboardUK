#!groovy​

def TestMethod(String SolutionFile) {
    bat """
        dir ${SolutionFile}
        """
    echo SolutionFile
}

pipeline {
    agent {
        node {
            label 'win'
            customWorkspace "ws\\${JOB_NAME.replace("%2F", "_")}"
        }
    }
    parameters {
        booleanParam(name: 'Restore', defaultValue: true, description: 'Dotnet Restore')
        booleanParam(name: 'Build', defaultValue: true, description: 'Dotnet Build')
        booleanParam(name: 'Publish', defaultValue: true, description: 'Dotnet Publish')
        booleanParam(name: 'Pack', defaultValue: true, description: 'Dotnet Pack')
        booleanParam(name: 'Push', defaultValue: false, description: 'Dotnet Push')
    }
    stages {
        stage('Restore') {
            when { expression { params.Restore == true } }
            steps {
                script {
                    bat """
                        dotnet restore WakeboardUK.sln
		                """
                    TestMethod("WakeboardUK.sln")
                }
            }
        }

        stage('Build') {
            when { expression { params.Build == true } }
            steps {
                script {
                    bat """
                        dotnet build WakeboardUK.sln
					    """
                }
            }
        }

        stage('Publish') {
            when { expression { params.Publish == true } }
            steps {
                script {
                    bat """
                        cd WakeboardUK2018
                        dotnet publish  --framework netcoreapp2.0 -o publish
                        """
                }
            }
        }

        stage('Pack') {
            when { expression { params.Pack == true } }
            steps {
                script {
                    bat """
                        cd WakeboardUK2018
                        copy WakeboardUK2018.nuspec publish/
                        dotnet pack WakeboardUK2018.nuspec
                        """
                }
            }
        }

        stage('Push') {
            when { expression { params.Push == true } }
            steps {
                withCredentials([string(credentialsId: 'wakeboarduk_myget_key', variable: 'nugetkey')]) {
                    script {
                        bat """
                        cd WakeboardUK2018
                        nuget push WakeboardUK2018.nupkg $nugetkey -Source https://www.myget.org/F/wakeboarduk/api/v2/package                        
                        """
                    }
                }
            }
        }


    }
}

