#!groovy​
pipeline {
    agent {
        label 'win'
    }
    parameters {
        booleanParam(name: 'DotNetRestore', defaultValue: true, description: 'Dotnet Restore')
    }
    stages {
         stage('Restore') {
            steps {
                script {
                    if ("${params.DotNetRestore}" == "true") {
                        script {
                                bat """
								dotnet restore WakeboardUK.Web.sln
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
