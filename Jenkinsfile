#!groovy​
pipeline {
    agent {
        label 'win'
    }
    parameters {
        booleanParam(name: 'DotNetRestore', defaultValue: true, description: 'Dotnet Restore')
        booleanParam(name: 'DotNetBuild', defaultValue: true, description: 'Dotnet Build')
    }
    stages {
        stage('Restore') {
            steps {
                script {
                    if ("${params.DotNetRestore}" == "true") {
                        script {
                            bat """
								dotnet restore WakeboardUK.sln
							    """
                        }
                    } else {
                        echo "Skipped."
                    }
                }
            }

        }
    }
}
