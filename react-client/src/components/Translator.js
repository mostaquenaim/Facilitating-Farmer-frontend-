import { Translation } from 'react-i18next';

export const translate = (textContent) => {
  return <Translation>{(t, { i18n }) => t(textContent)}</Translation>;
};
