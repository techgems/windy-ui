const colors = require('tailwindcss/colors');

//Generated with: https://tailwind.ink/
const customColors = {
    primary: {
        'text': 'your color here',
        'light': 'your color here',
        'default': 'your color here',
        'dark': 'your color here'
    },
    secondary: {
        'text': 'your color here',
        'light': 'your color here',
        'default': 'your color here',
        'dark': 'your color here'
    }
};

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
                /*Define your colors here:*/
				primary: {
                    text: customColors.primary['text'],
                    light: customColors.primary['light'],
                    DEFAULT: customColors.primary['default'],
                    dark: customColors.primary['dark']
                },
                secondary: {
                    text: customColors.secondary['text'],
                    light: customColors.secondary['light'],
                    DEFAULT: customColors.secondary['default'],
                    dark: customColors.secondary['dark']
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
