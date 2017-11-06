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
        booleanParam(name: 'Pack', defaultValue: true, description: 'Dotnet Pack')
        booleanParam(name: 'Push', defaultValue: true, description: 'Dotnet Push')
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

        stage('Pack') {
            when { expression { params.Pack == true } }
            steps {
                script {
                    bat """
                        cd WakeboardUK2018
                        dotnet pack
                        """
                }
            }
        }

        stage('Push') {
            when { expression { params.Push == true } }
            steps {
                script {
                    bat """
                        cd WakeboardUK2018
                        nuget push WakeboardUK2018.1.0.0.nupkg $wakeboarduk_myget_key -Source https://www.myget.org/F/wakeboarduk/api/v2/package                        
                        """
                }
            }
        }


    }
}

