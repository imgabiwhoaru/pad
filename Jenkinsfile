#!groovy

pipeline {

  agent any

  options {
    buildDiscarder(logRotator(numToKeepStr: '10'))
    timestamps()
  }

  parameters {
    booleanParam(name: "CLEAN_WORKSPACE", description: "Check this option if you would like the workspace to be cleaned at the end.", defaultValue: true)
  }
//     environment {
//     ON_SUCCESS_SEND_EMAIL = "True"
//     ON_FAILURE_SEND_EMAIL = "True"
//   }
  stages() {

    stage("GITHUB") {
      steps {
        git branch: 'master',
          credentialsId: 'github-id',
          url: 'https://github.com/vicalmic/PostMaker'
      }
    }

    stage("BUILD") {
      steps {
        echo "INFO: Build NUMBER ${BUILD_NUMBER}"
        echo "INFO: Build TAG ${BUILD_TAG}"

      }
    }

    stage("TEST_BACKEND") {
      steps {
        echo "TEST_BACKEND stage"
      }
    }

    stage("TEST_FRONTEND") {
      when {
        expression {
          return params.TESTING_FRONTEND;
        }
      }

      steps {
        echo "${params.TESTING_FRONTEND}"
      }
    }

    stage("Continuous Delivery") {
      steps {
        script {
          echo "Continuous Delivery stage"
        }
      }
    }

    stage("Continuous Deployment") {
      steps {
        sh 'docker compose -f docker-compose.yml up --detach --force-recreate --build'
      }
    }

    stage("DEPLOY") {
      steps {
        echo "Deployment stage"
      }
    }
  }

  post {
    always {
      echo "INFO: Build NUMBER ${BUILD_NUMBER}"
      echo "INFO: Build TAG ${BUILD_TAG}"
    }

    success {
      echo "I am running because the job ran successfully"

      script {

        echo "POST SUCCESS"
      }

    //   script {
    //     if (ON_SUCCESS_SEND_EMAIL == "True") {
    //       emailext subject: '$DEFAULT_SUBJECT',
    //         body: '$DEFAULT_CONTENT',
    //         replyTo: '$DEFAULT_REPLYTO',
    //         to: '$DEFAULT_RECIPIENTS'
    //     }
    //   }

      cleanWs()
    }

    unstable {
      echo "The build is unstable. Try fix it"

      cleanWs()
    }

    failure {
      echo "Something happened"

    //   script {
    //     if (ON_FAILURE_SEND_EMAIL == "True") {
    //       emailext subject: '$DEFAULT_SUBJECT',
    //         body: '$DEFAULT_CONTENT',
    //         replyTo: '$DEFAULT_REPLYTO',
    //         to: '$DEFAULT_RECIPIENTS'
    //     }
    //   }
      cleanWs()
    }
  }
}