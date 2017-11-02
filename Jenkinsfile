#!groovy​
def TestMethod(String SolutionFile){
    bat """
        dir ${SolutionFile}
        """
    echo SolutionFile
}

pipeline {
    agent {
        label 'win'
    }
    parameters {
        booleanParam(name: 'Restore', defaultValue: true, description: 'Dotnet Restore')
        booleanParam(name: 'Build', defaultValue: true, description: 'Dotnet Build')
        booleanParam(name: 'Publish', defaultValue: true, description: 'Dotnet Publish')
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
					    dotnet publish -o ..\\Publish
				        """
                }
            }
        }
    }
}

