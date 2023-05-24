# Understanding

1. docker-compose.yml

   - [Docker](https://www.docker.com/) is a containerization tool that makes running software easier and more reliable, by packaging/containing the software inside an image (Docker image). The image can run on any machine, OS that have Docker installed, and will behave the same, thanks to virtualization technology.
   - [Docker Desktop for Windows](https://docs.docker.com/docker-for-windows/install/) comes with 2 CLI tools: `docker` CLI and `docker-compose`
   - `docker` CLI is used to manage simple container run/start/stop/build/.etc flow. It is usually used with only one container at a time
   - `docker-compose` ([Docker Compose](https://docs.docker.com/compose/)) extends `docker` CLI functions, can orchestrate multiple containers at once, and make it more easy to work with the same containers in the next run. It also helps with executing scripts inside the containers, which is why in our case, we use `docker-compose`.

     - To start docker containers using `docker-compose`, the CLI command is `docker-compose up`
     - In above guideline, we used `docker-compose up -d`. The `-d` argument means to run in **detached** mode, so the CLI process ends after docker starts, instead of keeping the CLI and the Console windows active.

   - `docker-compose.yml` content

     The `docker-compose.yml` is used to start a docker container for our DynamoDB Local instance.Notice the following sections:

     ```yaml
     volumes:
       dynamodb_data:

     services:
       dynamodb:
         image: amazon/dynamodb-local
         command: -jar DynamoDBLocal.jar -sharedDb -dbPath /home/dynamodblocal/data/
         volumes:
           - ./dynamodb_data:/home/dynamodblocal/data
         ports:
           - "8000:8000"
     ```

     - `volumes`:

       This section tells Docker to user a local directory as a volume to mount on the Docker container. It means the Docker container can use this host directory in the container file system. This makes persisting data possible for DynamoDB Local instance.

     - `services`:

       - `images`: This property tells Docker what is/are the base image(s) to start with. In our case, it is `amazon/dynamodb-local` image. The image(s) can be found on offical, public Docker image hubs (e.g: [Amazon DynamoDB Local](https://hub.docker.com/r/amazon/dynamodb-local/)), or any public/private Docker image registry. We'll come back to this later when we deploy the application to our private container registry on AWS ECR!.

       - `command`: This property tells Docker which command should be executed when running the container. In our case, it is to run `DynamoDBLocal.jar` file, with a shared DB path to persist data.

       - `volumes`: This maps the above volume section with the container file system.

       - `ports`: This maps/forwards the container port to the host port. Make sure there's no process listening to this port on the host OS. By default, DynamoDB local runs in port `8000` inside the container. You must forward this port to host OS, otherwise nothing can connect to DynamoDB local instance in the container. If you want to map to another port, e.g: `1234`, change the value to `1234:8000`.
