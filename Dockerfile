FROM openjdk:11.0.8-jre-slim-buster

ARG NODE_VERSION=16
ARG OPENAPI_GEN_VERSION=5.1.0

RUN apt-get update && \
    apt-get install -y curl

RUN curl -fsSL https://deb.nodesource.com/setup_${NODE_VERSION}.x | bash - \
    && apt-get install -y nodejs

WORKDIR /app

COPY openapitools.json package.json package-lock.json /app/
COPY scripts /app/scripts/
COPY config /app/config/
COPY templates /app/templates/

RUN npm install -g @openapitools/openapi-generator-cli
RUN openapi-generator-cli version-manager set $OPENAPI_GEN_VERSION

ENTRYPOINT ["openapi-generator-cli"]
