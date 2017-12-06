DOCKER_ENV=''
DOCKER_TAG=''

case "$TRAVIS_BRANCH" in
    "master"
        DOCKER_ENV=production
        DOCKER_TAG=latest
        ;;
    "develop"
        DOCKER_ENV=development
        DOCKER_TAG=develop
        ;;
esac

docker login -u $DOCKER_USERNAME -p $DOCKER_PASSWORD

docker build -f /Taxes.api/Dockerfile.$DOCKER_ENV -t taxes-api:$DOCKER_TAG Taxes.api --no-cache
docker build -f /Taxes.services/Dockerfile.$DOCKER_ENV -t taxes-services:$DOCKER_TAG Taxes.services --no-cache

docker tag taxes-api:$DOCKER_TAG $DOCKER_USERNAME/taxes-api:$DOCKER_TAG
docker tag taxes-services:$DOCKER_TAG $DOCKER_USERNAME/taxes-services:$DOCKER_TAG

docker push $DOCKER_USERNAME/taxes-api:$DOCKER_TAG
docker push $DOCKER_USERNAME/taxes-services:$DOCKER_TAG

