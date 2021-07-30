const colors = require('tailwindcss/colors');

//Generated with: https://tailwind.ink/
const customColors = {
    pine: {
        '50': '#eef5f5',
        '100': '#ceeff4',
        '200': '#97e5e6',
        '300': '#49d9e8',
        '400': '#26ada1',
        '500': '#1b927c',
        '600': '#187b63',
        '700': '#175e4e',
        '800': '#12413a',
        '900': '#0c282b',
    },
    olive: {
        '50': '#fbfaf4',
        '100': '#f8efbd',
        '200': '#f0dd83',
        '300': '#d9b951',
        '400': '#b98f2c',
        '500': '#9a7016',
        '600': '#7d560e',
        '700': '#60410d',
        '800': '#412d0b',
        '900': '#2c1c09',
    },
    seagreen: {
        '50': '#f3f6f4',
        '100': '#e0efea',
        '200': '#b9e4d1',
        '300': '#81c8a5',
        '400': '#3fa776',
        '500': '#2c8b4e',
        '600': '#26743a',
        '700': '#21582f',
        '800': '#183d24',
        '900': '#11261b',
    }
}

module.exports = {
    purge: [],
    darkMode: false, // At this moment, Windy UI components do not support dark mode.
    theme: {
        colors: {
            transparent: 'transparent',
            current: 'currentColor',
            black: colors.black,
            white: colors.white,
            gray: colors.coolGray,
            red: colors.red,
            yellow: colors.amber,
            green: colors.emerald,
            blue: colors.blue,
            indigo: colors.indigo,
            purple: colors.violet,
            pink: colors.pink,
        },
        extend: {
            colors: {
                primary: {
                    text: 'white',
                    light: customColors.pine['100'],
                    DEFAULT: customColors.pine['400'],
                    dark: customColors.pine['500']
                },
                secondary: {
                    text: 'white',
                    light: customColors.olive['200'],
                    DEFAULT: customColors.olive['400'],
                    dark: customColors.olive['500']
                },
                success: {
                    text: 'white',
                    light: colors.emerald['100'],
                    DEFAULT: colors.emerald['600'],
                    dark: colors.emerald['700']
                },
                danger: {
                    text: 'white',
                    light: colors.red['200'],
                    DEFAULT: colors.red['600'],
                    dark: colors.red['700']
                },
                info: {
                    text: 'white',
                    light: colors.lightBlue['200'],
                    DEFAULT: colors.lightBlue['500'],
                    dark: colors.lightBlue['700']
                },
                warning: {
                    text: colors.gray['800'],
                    light: colors.amber['200'],
                    DEFAULT: colors.amber['300'],
                    dark: colors.amber['500']
                },
                neutral: {
                    text: colors.gray['100'],
                    light: colors.gray['200'],
                    DEFAULT: colors.gray['600'],
                    dark: colors.gray['700']
                }
            },
            fontFamily: {
                header: ["Montserrat"],
                body: ["Raleway"]
            },
            animation: {
                'fadein-500': "fadeIn 0.5s ease-in forwards",
                'fadein-400': "fadeIn 0.4s ease-in forwards",
                'fadein-300': "fadeIn 0.3s ease-in forwards",
                'fadeout-400': "fadeOut 0.4s ease-out forwards",
                'fadeout-300': "fadeOut 0.3s ease-out forwards",
                'fadeout-200': "fadeOut 0.2s ease-out forwards"
            },
            keyframes: {
                fadeIn: {
                    "0%": { opacity: 0 },
                    "100%": { opacity: 1 }
                },
                fadeOut: {
                    "0%": { opacity: 1 },
                    "100%": { opacity: 0 }
                }
            }
        },
    },
    variants: {
        extend: {},
    },
    plugins: [
        require('@tailwindcss/forms')
    ],
}
