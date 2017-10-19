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
                            dir("/WakeboardUK.Web") {
                                bat """
								dotnet restore WakeboardUK.Web.csproj
							    """
                            }
                        }
                    } else {
                        echo "Skipped."
                    }
                }
            }
        }
    }
}
