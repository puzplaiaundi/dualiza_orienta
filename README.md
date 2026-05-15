# Dualiza Orienta VR

Proyecto de realidad virtual desarrollado con Unity para crear una experiencia inmersiva de orientación educativa y profesional.

La aplicación permite al usuario recorrer diferentes escenas interactivas en VR, visualizar espacios 360º, recibir instrucciones mediante audio y paneles, e interactuar con objetos relacionados con distintos entornos formativos.

## Descripción general

**Dualiza Orienta VR** es una experiencia de orientación en realidad virtual pensada para acercar al usuario a diferentes contextos formativos mediante escenas inmersivas e interactivas.

El proyecto combina:

- Escenas 3D desarrolladas en Unity.
- Vídeos e imágenes 360º.
- Interacción con objetos mediante XR Interaction Toolkit.
- Audios explicativos e instrucciones.
- Paneles informativos.
- Mecánicas sencillas de interacción, validación y finalización de tareas.

El objetivo principal es ofrecer una experiencia visual e interactiva que facilite la presentación de espacios, ciclos formativos o actividades de orientación de una forma más atractiva e inmersiva.

## Tecnologías utilizadas

- Unity
- XR Interaction Toolkit
- OpenXR
- Meta Quest / dispositivos VR compatibles
- C#
- TextMeshPro
- Modelos 3D en formato FBX / GLB
- Imágenes y vídeos 360º

## Estructura principal del proyecto

```text
Assets/
├── Audio/                  # Audios utilizados en las escenas
├── Materiales/             # Materiales del proyecto
├── Models/                 # Modelos 3D
├── Prefabs/                # Prefabs reutilizables
├── Scenes/                 # Escenas del proyecto
│   └── Funcionales/        # Escenas principales funcionales
├── Scripts/                # Scripts C# del proyecto
├── skybox/                 # Materiales, imágenes y recursos 360º
├── XR/                     # Configuración y recursos XR
├── XRI/                    # Configuración de XR Interaction Toolkit
├── TextMesh Pro/           # Recursos de TextMeshPro
Packages/                   # Paquetes del proyecto
ProjectSettings/            # Configuración general de Unity
```

## Escenas principales

El proyecto contiene varias escenas funcionales ubicadas principalmente en:

```text
Assets/Scenes/Funcionales/
```

Entre ellas se incluyen escenas de presentación, instrucciones y espacios interactivos relacionados con distintos entornos del proyecto.

Algunas escenas destacadas son:

- `Scene1Recibidor`
- `Instrucciones_Infor_video`
- `Instrucciones_Eri_video`
- `RecibidorEri`
- `RecibidorProcesador`

La escena inicial y el orden de carga deben comprobarse desde:

```text
File > Build Settings
```

dentro de Unity.

## Scripts principales

El proyecto incluye varios scripts personalizados para controlar la lógica de interacción y navegación.

Algunos de los scripts principales son:

```text
Assets/Scripts/
├── ActivarAlFinalizar.cs
├── CepilloVR.cs
├── CuentaAtrasJuego.cs
├── FadeOutActivate.cs
├── IgnorarColisionRAMPlaca.cs
├── LoadScene.cs
├── MostrarMensajeXR.cs
├── ObjetoFrotable.cs
├── PanelMiraCamara.cs
├── ReproducirAudioDespues.cs
├── SocketConValidacion.cs
├── TensiometroBlendShapes.cs
└── UnirPuntos.cs
```

Funciones generales de estos scripts:

- Cambio de escena.
- Activación y desactivación de objetos.
- Validación de objetos colocados en sockets.
- Reproducción secuencial de audios.
- Temporizador de juego.
- Mensajes de superación o fallo.
- Efectos visuales como humo, confeti o cambios de material.
- Paneles que miran hacia la cámara.
- Unión visual entre puntos u objetos mediante líneas.

## Recursos multimedia

El proyecto utiliza recursos multimedia como:

- Audios en formato `.mp3`.
- Imágenes 360º.
- Materiales de skybox.
- Modelos 3D.
- Vídeos 360º.

Por motivos de tamaño, los vídeos pesados no deberían subirse directamente al repositorio.

## Vídeos externos

Los vídeos del proyecto deben almacenarse fuera del repositorio, por ejemplo en Google Drive.

Después de clonar el proyecto, los vídeos deben descargarse manualmente y colocarse en la carpeta indicada por el proyecto, por ejemplo:

```text
Assets/Video/
```

o en la carpeta equivalente utilizada por las escenas.

> Nota: si los vídeos no están incluidos, algunas escenas pueden mostrar referencias vacías o no reproducir correctamente el contenido 360º hasta que se copien los archivos correspondientes.

### Carpeta de vídeos


```text
https://drive.google.com/drive/folders/1681xk_UwVFIGxQyUsTKHJzje0ZiRzadw?usp=drive_link
```

## Archivos excluidos del repositorio

El repositorio ignora archivos generados automáticamente o demasiado pesados, como:

- Carpeta `Library/`
- Carpeta `Temp/`
- Carpeta `Obj/`
- Builds de Unity
- APK / AAB
- Vídeos pesados
- Archivos temporales de compilación
- Carpetas `*_BackUpThisFolder_ButDontShipItWithYourGame/`
- Carpeta `.utmp/`
- Archivos de recuperación de Unity

Esto permite que el repositorio sea más limpio y fácil de clonar.

## Requisitos para abrir el proyecto

Para abrir correctamente el proyecto se recomienda disponer de:

- Unity instalado.
- Módulo de compilación Android para Unity.
- XR Interaction Toolkit.
- OpenXR configurado.
- Un visor VR compatible, por ejemplo Meta Quest.
- Los vídeos externos descargados si se quieren probar todas las escenas multimedia.

## Cómo abrir el proyecto

1. Clonar el repositorio:

```bash
git clone https://github.com/puzplaiaundi/dualiza_orienta.git
```

2. Abrir Unity Hub.

3. Seleccionar **Add project from disk**.

4. Elegir la carpeta del proyecto clonado.

5. Abrir el proyecto con la versión de Unity correspondiente.

6. Descargar los vídeos externos desde Drive, si procede.

7. Colocar los vídeos en la carpeta correspondiente del proyecto
8. ```text
   Assets/Video/
   ```

9. Abrir una escena desde:

```text
Assets/Scenes/Funcionales/
```

9. Ejecutar la escena desde el editor o compilar para dispositivo VR.

## Compilación para Meta Quest

Para compilar el proyecto para Meta Quest:

1. Abrir Unity.
2. Ir a:

```text
File > Build Settings
```

3. Seleccionar Android como plataforma o mejor "Meta Quest".
4. Comprobar que las escenas necesarias están añadidas en el orden correcto.
5. Revisar la configuración de XR/OpenXR.
6. Conectar el visor Meta Quest.
7. Ejecutar:

```text
Build And Run
```

Si se usan vídeos muy pesados, se recomienda no incluirlos directamente dentro de la APK para evitar que el archivo final sea demasiado grande.

## Recomendaciones importantes

- No subir vídeos grandes directamente a GitHub.
- No subir carpetas de build generadas por Unity.
- No subir carpetas temporales como `.utmp/`.
- Mantener actualizado el archivo `.gitignore`.
- Documentar siempre dónde deben colocarse los recursos externos.
- Revisar las referencias de los `VideoPlayer` si se mueven vídeos de carpeta.
- Comprobar el orden de escenas en Build Settings antes de compilar.
- 
## Créditos

Este proyecto utiliza algunos modelos 3D procedentes de Sketchfab y MakeHuman.

Los créditos completos de los modelos 3D utilizados, junto con sus autores, enlaces originales y licencias, están disponibles en el archivo:

[CREDITOS.md](CREDITOS.md)

## Estado del proyecto

El proyecto se encuentra en una versión estable de desarrollo, con las escenas principales, scripts e interacciones básicas implementadas.

Quedan como posibles mejoras futuras:

- Optimización del peso de modelos 3D.
- Gestión externa de vídeos pesados.
- Mejora de la documentación de escenas.
- Revisión de rendimiento en visor VR.
- Limpieza de assets no utilizados.
- Mejora de la estructura de carpetas.
- Incorporación de instrucciones más detalladas para instalación y despliegue.

## Autoría
Pablo Uzquiano.
Departamento de Berrikuntza del CIFP Plaiaundi de Irún.


Repositorio:

```text
https://github.com/puzplaiaundi/dualiza_orienta
```
