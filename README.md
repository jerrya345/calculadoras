# Calculadora de Áreas API

API REST que proporciona endpoints para calcular áreas de diferentes figuras geométricas.

## Características

- Cálculo de área de cuadrado
- Cálculo de área de rectángulo
- Cálculo de área de círculo
- Cálculo de área de triángulo

## Tecnologías Utilizadas

- .NET 9.0
- ASP.NET Core
- Swagger/OpenAPI

## Requisitos

- .NET 9.0 SDK o superior
- Visual Studio 2022 o Visual Studio Code

## Instalación

1. Clonar el repositorio:
```bash
git clone https://github.com/jerrya345/calculadoras.git
```

2. Navegar al directorio del proyecto:
```bash
cd calculadoras
```

3. Restaurar las dependencias:
```bash
dotnet restore
```

4. Ejecutar el proyecto:
```bash
dotnet run
```

## Uso

Una vez que el proyecto esté en ejecución, puedes acceder a la documentación Swagger en:
```
https://localhost:5001/swagger
```

### Endpoints Disponibles

- `GET /api/CalculadoraAreas/cuadrado?lado={valor}`
- `GET /api/CalculadoraAreas/rectangulo?base={valor}&altura={valor}`
- `GET /api/CalculadoraAreas/circulo?radio={valor}`
- `GET /api/CalculadoraAreas/triangulo?base={valor}&altura={valor}`

## Contribución

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.
