#!groovy​
pipeline {
    agent {
        label 'win'
    }
    parameters {
        booleanParam(name: 'Restore', defaultValue: true, description: 'Dotnet Restore')
    }
    stages {
         stage('Restore') {
            steps {
                script {
                    if (env.Restore == true) {
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
