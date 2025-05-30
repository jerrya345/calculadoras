# Calculadora de Áreas y Volúmenes API

API REST que proporciona endpoints para calcular áreas y volúmenes de diferentes figuras geométricas.

## Características

### Cálculo de Áreas
- Cálculo de área de cuadrado
- Cálculo de área de rectángulo
- Cálculo de área de círculo
- Cálculo de área de triángulo

### Cálculo de Volúmenes
- Cálculo de volumen de cubo
- Cálculo de volumen de prisma rectangular
- Cálculo de volumen de esfera
- Cálculo de volumen de cilindro
- Cálculo de volumen de pirámide

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

#### Cálculo de Áreas
- `GET /api/CalculadoraAreas/cuadrado?lado={valor}`
- `GET /api/CalculadoraAreas/rectangulo?base={valor}&altura={valor}`
- `GET /api/CalculadoraAreas/circulo?radio={valor}`
- `GET /api/CalculadoraAreas/triangulo?base={valor}&altura={valor}`

#### Cálculo de Volúmenes
- `GET /api/CalculadoraVolumenes/cubo?lado={valor}`
- `GET /api/CalculadoraVolumenes/prisma-rectangular?largo={valor}&ancho={valor}&alto={valor}`
- `GET /api/CalculadoraVolumenes/esfera?radio={valor}`
- `GET /api/CalculadoraVolumenes/cilindro?radio={valor}&altura={valor}`
- `GET /api/CalculadoraVolumenes/piramide?base={valor}&altura={valor}`

## Contribución

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.
