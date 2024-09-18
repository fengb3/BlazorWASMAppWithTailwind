# How to Setup Tailwind CSS

### create a new project:

```bash
npm init
```

### add dependencies:

```bash
npm install -D tailwindcss postcss autoprefixer
```

### initialize tailwind:

```bash
npx tailwindcss init
```

### add following js to ´tailwind.config.js`

```javascript
/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./<dir-to-you-components>/**/*.{html,razor,cs}"],
    theme: {
        extend: {},
    },
    plugins: [],
}
```

### add following js to ´postcss.config.js`

```javascript
// postcss.config.js
module.exports = {
    plugins: {
        'postcss-import': {},
        tailwindcss: {},
        autoprefixer: {},
    }
}
```

### Add the Tailwind directives to your CSS

wwwroot/css/app.css

```css
@tailwind base;
@tailwind components;
@tailwind utilities;
```

### add following xml to `.csproj`

```xml

<Target Name="Tailwind" BeforeTargets="Build">
    <Exec Command="npm run css:build"/>
</Target>

<!--post css to make scopedcss from tailwind css-->
<Target Name="PostBuild" BeforeTargets="Build">
    <Exec Command="npx postcss $(ProjectDir)obj\$(ConfigurationName)\$(TargetFramework)\scopedcss\bundle\$(ProjectName).styles.css -r"/>
</Target>
```

### start the ´postcss` process:

```bash
npx tailwindcss -i ./wwwroot/css/app.css -o ./wwwroot/css/site.css --watch
```
