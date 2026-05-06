# Multi-stage build for Blazor WebAssembly standalone app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies first (for layer caching)
COPY ["ShrekQuiz/ShrekQuiz.csproj", "ShrekQuiz/"]
RUN dotnet restore "ShrekQuiz/ShrekQuiz.csproj"

# Copy everything else and publish
COPY . .
RUN dotnet publish "ShrekQuiz/ShrekQuiz.csproj" -c Release -o /app/publish

# Runtime stage: serve static files with nginx
FROM nginx:alpine
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80
